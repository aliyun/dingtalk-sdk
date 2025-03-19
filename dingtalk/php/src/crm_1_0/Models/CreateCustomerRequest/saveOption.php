<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\CreateCustomerRequest;

use AlibabaCloud\Tea\Model;

class saveOption extends Model
{
    /**
     * @example APPEND_CONTACT_FORCE
     *
     * @var string
     */
    public $customerExistedPolicy;

    /**
     * @example false
     *
     * @var bool
     */
    public $skipDuplicateCheck;

    /**
     * @example 0
     *
     * @var int
     */
    public $subscribePolicy;

    /**
     * @example true
     *
     * @var bool
     */
    public $throwExceptionWhileSavingContactFailed;
    protected $_name = [
        'customerExistedPolicy' => 'customerExistedPolicy',
        'skipDuplicateCheck' => 'skipDuplicateCheck',
        'subscribePolicy' => 'subscribePolicy',
        'throwExceptionWhileSavingContactFailed' => 'throwExceptionWhileSavingContactFailed',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->customerExistedPolicy) {
            $res['customerExistedPolicy'] = $this->customerExistedPolicy;
        }
        if (null !== $this->skipDuplicateCheck) {
            $res['skipDuplicateCheck'] = $this->skipDuplicateCheck;
        }
        if (null !== $this->subscribePolicy) {
            $res['subscribePolicy'] = $this->subscribePolicy;
        }
        if (null !== $this->throwExceptionWhileSavingContactFailed) {
            $res['throwExceptionWhileSavingContactFailed'] = $this->throwExceptionWhileSavingContactFailed;
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
        if (isset($map['customerExistedPolicy'])) {
            $model->customerExistedPolicy = $map['customerExistedPolicy'];
        }
        if (isset($map['skipDuplicateCheck'])) {
            $model->skipDuplicateCheck = $map['skipDuplicateCheck'];
        }
        if (isset($map['subscribePolicy'])) {
            $model->subscribePolicy = $map['subscribePolicy'];
        }
        if (isset($map['throwExceptionWhileSavingContactFailed'])) {
            $model->throwExceptionWhileSavingContactFailed = $map['throwExceptionWhileSavingContactFailed'];
        }

        return $model;
    }
}
