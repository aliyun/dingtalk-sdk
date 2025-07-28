<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryChannelStaffInfoByMobileRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 158xxxxxxxx
     *
     * @var string
     */
    public $mobile;

    /**
     * @description This parameter is required.
     *
     * @example dingxxxxxxx
     *
     * @var string
     */
    public $targetCorpId;
    protected $_name = [
        'mobile' => 'mobile',
        'targetCorpId' => 'targetCorpId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->targetCorpId) {
            $res['targetCorpId'] = $this->targetCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryChannelStaffInfoByMobileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['targetCorpId'])) {
            $model->targetCorpId = $map['targetCorpId'];
        }

        return $model;
    }
}
