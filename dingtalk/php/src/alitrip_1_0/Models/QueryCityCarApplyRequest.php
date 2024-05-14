<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCityCarApplyRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example corpx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 2021-03-18 20:26:56
     *
     * @var string
     */
    public $createdEndAt;

    /**
     * @example 2021-03-18 20:26:56
     *
     * @var string
     */
    public $createdStartAt;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 20
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example apply1
     *
     * @var string
     */
    public $thirdPartApplyId;

    /**
     * @example user1
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId'           => 'corpId',
        'createdEndAt'     => 'createdEndAt',
        'createdStartAt'   => 'createdStartAt',
        'pageNumber'       => 'pageNumber',
        'pageSize'         => 'pageSize',
        'thirdPartApplyId' => 'thirdPartApplyId',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createdEndAt) {
            $res['createdEndAt'] = $this->createdEndAt;
        }
        if (null !== $this->createdStartAt) {
            $res['createdStartAt'] = $this->createdStartAt;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->thirdPartApplyId) {
            $res['thirdPartApplyId'] = $this->thirdPartApplyId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCityCarApplyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createdEndAt'])) {
            $model->createdEndAt = $map['createdEndAt'];
        }
        if (isset($map['createdStartAt'])) {
            $model->createdStartAt = $map['createdStartAt'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['thirdPartApplyId'])) {
            $model->thirdPartApplyId = $map['thirdPartApplyId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
