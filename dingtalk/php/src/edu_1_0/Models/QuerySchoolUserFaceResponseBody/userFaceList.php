<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySchoolUserFaceResponseBody;

use AlibabaCloud\Tea\Model;

class userFaceList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 200001
     *
     * @var string
     */
    public $faceId;

    /**
     * @description This parameter is required.
     *
     * @example 小明
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 1有效；0无效
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @example 30001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'faceId' => 'faceId',
        'name' => 'name',
        'status' => 'status',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->faceId) {
            $res['faceId'] = $this->faceId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userFaceList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['faceId'])) {
            $model->faceId = $map['faceId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
