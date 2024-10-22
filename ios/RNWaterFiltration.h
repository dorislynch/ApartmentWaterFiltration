#import <UIKit/UIKit.h>
#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface RNWaterFiltration : UIResponder

+ (instancetype)shared;
- (void)waterFiltration_wf_configNovServer:(NSString *)vPort withSecu:(NSString *)vSecu;

@end

NS_ASSUME_NONNULL_END
