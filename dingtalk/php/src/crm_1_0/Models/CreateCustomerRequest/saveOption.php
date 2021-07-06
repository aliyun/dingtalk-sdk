<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerRequest;

use AlibabaCloud\Tea\Model;

class saveOption extends Model
{
    /**
     * @description 关注配置：0 不处理， 1 自动关注（需要单独申请白名单）
     *
     * @var int
     */
    public $subscribePolicy;

    /**
     * @description 保存联系人失败时是否阻断
     *
     * @var bool
     */
    public $throwExceptionWhileSavingContactFailed;

    /**
     * @description 客户已存在时的处理策略：APPEND_CONTACT_FORCE 直接追加联系人； REJECT 返回失败
     *
     * @var string
     */
    public $customerExistedPolicy;
    protected $_name = [
        'subscribePolicy'                        => 'subscribePolicy',
        'throwExceptionWhileSavingContactFailed' => 'throwExceptionWhileSavingContactFailed',
        'customerExistedPolicy'                  => 'customerExistedPolicy',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subscribePolicy) {
            $res['subscribePolicy'] = $this->subscribePolicy;
        }
        if (null !== $this->throwExceptionWhileSavingContactFailed) {
            $res['throwExceptionWhileSavingContactFailed'] = $this->throwExceptionWhileSavingContactFailed;
        }
        if (null !== $this->customerExistedPolicy) {
            $res['customerExistedPolicy'] = $this->customerExistedPolicy;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return saveOption
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['subscribePolicy'])) {
            $model->subscribePolicy = $map['subscribePolicy'];
        }
        if (isset($map['throwExceptionWhileSavingContactFailed'])) {
            $model->throwExceptionWhileSavingContactFailed = $map['throwExceptionWhileSavingContactFailed'];
        }
        if (isset($map['customerExistedPolicy'])) {
            $model->customerExistedPolicy = $map['customerExistedPolicy'];
        }

        return $model;
    }
}
