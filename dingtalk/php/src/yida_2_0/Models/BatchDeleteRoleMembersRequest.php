<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_2_0\Models;

use AlibabaCloud\Tea\Model;

class BatchDeleteRoleMembersRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dingxxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $memberIds;

    /**
     * @var int
     */
    public $pageNumber;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @description This parameter is required.
     *
     * @example ROLE-71dc7859-17df-490d-a93d-eb5506e31f42
     *
     * @var string
     */
    public $roleUuid;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $token;

    /**
     * @description This parameter is required.
     *
     * @example 501453
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId' => 'corpId',
        'memberIds' => 'memberIds',
        'pageNumber' => 'pageNumber',
        'pageSize' => 'pageSize',
        'roleUuid' => 'roleUuid',
        'token' => 'token',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->memberIds) {
            $res['memberIds'] = $this->memberIds;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->roleUuid) {
            $res['roleUuid'] = $this->roleUuid;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchDeleteRoleMembersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['memberIds'])) {
            $model->memberIds = $map['memberIds'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['roleUuid'])) {
            $model->roleUuid = $map['roleUuid'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
