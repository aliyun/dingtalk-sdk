<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCityCarApplyRequest extends Model
{
    /**
     * @description 第三方企业ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 审批单创建时间小于值
     *
     * @var string
     */
    public $createdEndAt;

    /**
     * @description 审批单创建时间大于等于值
     *
     * @var string
     */
    public $createdStartAt;

    /**
     * @description 页码，要求大于等于1，默认1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 每页数据量，要求大于等于1，默认20
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 三方审批单ID
     *
     * @var string
     */
    public $thirdPartApplyId;

    /**
     * @description 第三方员工ID
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
