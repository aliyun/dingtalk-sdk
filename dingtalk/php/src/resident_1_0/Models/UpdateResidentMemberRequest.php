<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\UpdateResidentMemberRequest\residentUpdateInfo;
use AlibabaCloud\Tea\Model;

class UpdateResidentMemberRequest extends Model
{
    /**
     * @description 人员更新信息
     *
     * @var residentUpdateInfo
     */
    public $residentUpdateInfo;

    /**
     * @description unionId
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'residentUpdateInfo' => 'residentUpdateInfo',
        'unionId'            => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->residentUpdateInfo) {
            $res['residentUpdateInfo'] = null !== $this->residentUpdateInfo ? $this->residentUpdateInfo->toMap() : null;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateResidentMemberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['residentUpdateInfo'])) {
            $model->residentUpdateInfo = residentUpdateInfo::fromMap($map['residentUpdateInfo']);
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
