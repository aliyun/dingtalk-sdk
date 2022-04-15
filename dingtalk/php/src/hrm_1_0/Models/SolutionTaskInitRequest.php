<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class SolutionTaskInitRequest extends Model
{
    /**
     * @description 任务业务模块，如training, performance等
     *
     * @var string
     */
    public $category;

    /**
     * @description 任务要求的截止时间
     *
     * @var int
     */
    public $claimTime;

    /**
     * @description 任务描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 任务完成时间
     *
     * @var int
     */
    public $finishTime;

    /**
     * @description 外部的任务唯一标识
     *
     * @var string
     */
    public $outerId;

    /**
     * @description 任务状态，如running,finished
     *
     * @var string
     */
    public $status;

    /**
     * @description 任务名称
     *
     * @var string
     */
    public $title;

    /**
     * @description 任务执行人userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 解决方案类型
     *
     * @var string
     */
    public $solutionType;
    protected $_name = [
        'category'     => 'category',
        'claimTime'    => 'claimTime',
        'description'  => 'description',
        'finishTime'   => 'finishTime',
        'outerId'      => 'outerId',
        'status'       => 'status',
        'title'        => 'title',
        'userId'       => 'userId',
        'solutionType' => 'solutionType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->claimTime) {
            $res['claimTime'] = $this->claimTime;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->finishTime) {
            $res['finishTime'] = $this->finishTime;
        }
        if (null !== $this->outerId) {
            $res['outerId'] = $this->outerId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->solutionType) {
            $res['solutionType'] = $this->solutionType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SolutionTaskInitRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['claimTime'])) {
            $model->claimTime = $map['claimTime'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['finishTime'])) {
            $model->finishTime = $map['finishTime'];
        }
        if (isset($map['outerId'])) {
            $model->outerId = $map['outerId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['solutionType'])) {
            $model->solutionType = $map['solutionType'];
        }

        return $model;
    }
}
