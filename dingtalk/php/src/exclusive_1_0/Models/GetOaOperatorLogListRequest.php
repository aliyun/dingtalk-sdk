<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOaOperatorLogListRequest extends Model
{
    /**
     * @description 操作分类（一级目录）
     *
     * @var string[]
     */
    public $categoryList;

    /**
     * @description 结束时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 操作员userId
     *
     * @var string
     */
    public $opUserId;

    /**
     * @description 分页起始页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 起始时间
     *
     * @var int
     */
    public $startTime;
    protected $_name = [
        'categoryList' => 'categoryList',
        'endTime'      => 'endTime',
        'opUserId'     => 'opUserId',
        'pageNumber'   => 'pageNumber',
        'pageSize'     => 'pageSize',
        'startTime'    => 'startTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->categoryList) {
            $res['categoryList'] = $this->categoryList;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOaOperatorLogListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['categoryList'])) {
            if (!empty($map['categoryList'])) {
                $model->categoryList = $map['categoryList'];
            }
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
