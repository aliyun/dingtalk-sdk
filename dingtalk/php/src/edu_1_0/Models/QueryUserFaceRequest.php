<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserFaceRequest extends Model
{
    /**
     * @description 设备序列号
     *
     * @var string
     */
    public $sn;

    /**
     * @description 人脸id
     *
     * @var string
     */
    public $faceId;
    protected $_name = [
        'sn'     => 'sn',
        'faceId' => 'faceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
        }
        if (null !== $this->faceId) {
            $res['faceId'] = $this->faceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryUserFaceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }
        if (isset($map['faceId'])) {
            $model->faceId = $map['faceId'];
        }

        return $model;
    }
}
