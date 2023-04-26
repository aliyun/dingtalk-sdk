<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryUserFaceRequest extends Model
{
    /**
     * @example 30001
     *
     * @var string
     */
    public $faceId;

    /**
     * @example sn123
     *
     * @var string
     */
    public $sn;
    protected $_name = [
        'faceId' => 'faceId',
        'sn'     => 'sn',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->faceId) {
            $res['faceId'] = $this->faceId;
        }
        if (null !== $this->sn) {
            $res['sn'] = $this->sn;
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
        if (isset($map['faceId'])) {
            $model->faceId = $map['faceId'];
        }
        if (isset($map['sn'])) {
            $model->sn = $map['sn'];
        }

        return $model;
    }
}
