
#import "RNZendeskTecnovix.h"

@implementation RNZendeskTecnovix

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
RCT_EXPORT_MODULE()

RCT_EXPORT_METHOD(addEvent:(NSString *)name)
{
  RCTLogInfo(@"Pretending to create an event %@ at %@", name);
}
@end
  