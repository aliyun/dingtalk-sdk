<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetClassTagResponseBody extends Model
{
    /**
     * @var string
     */
    public $creatorName;

    /**
     * @example 1
     *
     * @var int
     */
    public $dataType;

    /**
     * @example 描述信息
     *
     * @var string
     */
    public $description;

    /**
     * @example 1
     *
     * @var string
     */
    public $innerDownload;

    /**
     * @example 1
     *
     * @var string
     */
    public $innerTransfer;

    /**
     * @example 张三
     *
     * @var string
     */
    public $modifierName;

    /**
     * @example 标签名称
     *
     * @var string
     */
    public $name;

    /**
     * @example 1
     *
     * @var string
     */
    public $outOp;

    /**
     * @example 1
     *
     * @var int
     */
    public $rank;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @example 1735023822867
     *
     * @var int
     */
    public $updateTime;
    protected $_name = [
        'creatorName' => 'creatorName',
        'dataType' => 'dataType',
        'description' => 'description',
        'innerDownload' => 'innerDownload',
        'innerTransfer' => 'innerTransfer',
        'modifierName' => 'modifierName',
        'name' => 'name',
        'outOp' => 'outOp',
        'rank' => 'rank',
        'status' => 'status',
        'updateTime' => 'updateTime',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorName) {
            $res['creatorName'] = $this->creatorName;
        }
        if (null !== $this->dataType) {
            $res['dataType'] = $this->dataType;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->innerDownload) {
            $res['innerDownload'] = $this->innerDownload;
        }
        if (null !== $this->innerTransfer) {
            $res['innerTransfer'] = $this->innerTransfer;
        }
        if (null !== $this->modifierName) {
            $res['modifierName'] = $this->modifierName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->outOp) {
            $res['outOp'] = $this->outOp;
        }
        if (null !== $this->rank) {
            $res['rank'] = $this->rank;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->updateTime) {
            $res['updateTime'] = $this->updateTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetClassTagResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorName'])) {
            $model->creatorName = $map['creatorName'];
        }
        if (isset($map['dataType'])) {
            $model->dataType = $map['dataType'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['innerDownload'])) {
            $model->innerDownload = $map['innerDownload'];
        }
        if (isset($map['innerTransfer'])) {
            $model->innerTransfer = $map['innerTransfer'];
        }
        if (isset($map['modifierName'])) {
            $model->modifierName = $map['modifierName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['outOp'])) {
            $model->outOp = $map['outOp'];
        }
        if (isset($map['rank'])) {
            $model->rank = $map['rank'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['updateTime'])) {
            $model->updateTime = $map['updateTime'];
        }

        return $model;
    }
}
