<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\AddResidentMemberRequest\residentAddInfo;
use AlibabaCloud\Tea\Model;

class AddResidentMemberRequest extends Model
{
    /**
     * @description 人员信息
     *
     * @var residentAddInfo
     */
    public $residentAddInfo;
    protected $_name = [
        'residentAddInfo' => 'residentAddInfo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->residentAddInfo) {
            $res['residentAddInfo'] = null !== $this->residentAddInfo ? $this->residentAddInfo->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddResidentMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['residentAddInfo'])) {
            $model->residentAddInfo = residentAddInfo::fromMap($map['residentAddInfo']);
        }

        return $model;
    }
}
