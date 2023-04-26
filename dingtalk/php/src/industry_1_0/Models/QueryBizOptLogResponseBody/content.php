<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryBizOptLogResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @example 固定值 1-医疗组
     *
     * @var int
     */
    public $bizType;

    /**
     * @example 1-钉钉数据，2-自建数据
     *
     * @var int
     */
    public $dataType;

    /**
     * @example 23821
     *
     * @var int
     */
    public $id;

    /**
     * @var string
     */
    public $optAfterData;

    /**
     * @var string
     */
    public $optBeforeData;

    /**
     * @example 1-人员，2-部门
     *
     * @var int
     */
    public $optBizType;

    /**
     * @var string
     */
    public $optExtend;

    /**
     * @var string
     */
    public $optJobNumber;

    /**
     * @var string
     */
    public $optObjectCode;

    /**
     * @var string
     */
    public $optObjectName;

    /**
     * @var string
     */
    public $optObjectUserJobNo;

    /**
     * @example 1-成功，2-失败
     *
     * @var int
     */
    public $optSuccess;

    /**
     * @example 1622191102012
     *
     * @var int
     */
    public $optTime;

    /**
     * @example 0-删除，1-添加，2-修改，3-作废
     *
     * @var int
     */
    public $optType;

    /**
     * @var string
     */
    public $optUserCode;

    /**
     * @var string
     */
    public $optUserName;

    /**
     * @var string
     */
    public $remark;
    protected $_name = [
        'bizType'            => 'bizType',
        'dataType'           => 'dataType',
        'id'                 => 'id',
        'optAfterData'       => 'optAfterData',
        'optBeforeData'      => 'optBeforeData',
        'optBizType'         => 'optBizType',
        'optExtend'          => 'optExtend',
        'optJobNumber'       => 'optJobNumber',
        'optObjectCode'      => 'optObjectCode',
        'optObjectName'      => 'optObjectName',
        'optObjectUserJobNo' => 'optObjectUserJobNo',
        'optSuccess'         => 'optSuccess',
        'optTime'            => 'optTime',
        'optType'            => 'optType',
        'optUserCode'        => 'optUserCode',
        'optUserName'        => 'optUserName',
        'remark'             => 'remark',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->dataType) {
            $res['dataType'] = $this->dataType;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->optAfterData) {
            $res['optAfterData'] = $this->optAfterData;
        }
        if (null !== $this->optBeforeData) {
            $res['optBeforeData'] = $this->optBeforeData;
        }
        if (null !== $this->optBizType) {
            $res['optBizType'] = $this->optBizType;
        }
        if (null !== $this->optExtend) {
            $res['optExtend'] = $this->optExtend;
        }
        if (null !== $this->optJobNumber) {
            $res['optJobNumber'] = $this->optJobNumber;
        }
        if (null !== $this->optObjectCode) {
            $res['optObjectCode'] = $this->optObjectCode;
        }
        if (null !== $this->optObjectName) {
            $res['optObjectName'] = $this->optObjectName;
        }
        if (null !== $this->optObjectUserJobNo) {
            $res['optObjectUserJobNo'] = $this->optObjectUserJobNo;
        }
        if (null !== $this->optSuccess) {
            $res['optSuccess'] = $this->optSuccess;
        }
        if (null !== $this->optTime) {
            $res['optTime'] = $this->optTime;
        }
        if (null !== $this->optType) {
            $res['optType'] = $this->optType;
        }
        if (null !== $this->optUserCode) {
            $res['optUserCode'] = $this->optUserCode;
        }
        if (null !== $this->optUserName) {
            $res['optUserName'] = $this->optUserName;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['dataType'])) {
            $model->dataType = $map['dataType'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['optAfterData'])) {
            $model->optAfterData = $map['optAfterData'];
        }
        if (isset($map['optBeforeData'])) {
            $model->optBeforeData = $map['optBeforeData'];
        }
        if (isset($map['optBizType'])) {
            $model->optBizType = $map['optBizType'];
        }
        if (isset($map['optExtend'])) {
            $model->optExtend = $map['optExtend'];
        }
        if (isset($map['optJobNumber'])) {
            $model->optJobNumber = $map['optJobNumber'];
        }
        if (isset($map['optObjectCode'])) {
            $model->optObjectCode = $map['optObjectCode'];
        }
        if (isset($map['optObjectName'])) {
            $model->optObjectName = $map['optObjectName'];
        }
        if (isset($map['optObjectUserJobNo'])) {
            $model->optObjectUserJobNo = $map['optObjectUserJobNo'];
        }
        if (isset($map['optSuccess'])) {
            $model->optSuccess = $map['optSuccess'];
        }
        if (isset($map['optTime'])) {
            $model->optTime = $map['optTime'];
        }
        if (isset($map['optType'])) {
            $model->optType = $map['optType'];
        }
        if (isset($map['optUserCode'])) {
            $model->optUserCode = $map['optUserCode'];
        }
        if (isset($map['optUserName'])) {
            $model->optUserName = $map['optUserName'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }

        return $model;
    }
}
