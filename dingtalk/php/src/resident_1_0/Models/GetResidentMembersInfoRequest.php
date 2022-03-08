<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetResidentMembersInfoRequest extends Model
{
    /**
     * @var string
     */
    public $residentCropId;

    /**
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'residentCropId' => 'residentCropId',
        'userIdList'     => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->residentCropId) {
            $res['residentCropId'] = $this->residentCropId;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetResidentMembersInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['residentCropId'])) {
            $model->residentCropId = $map['residentCropId'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
