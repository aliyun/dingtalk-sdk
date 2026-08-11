<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class QuerySubjectPublicRiskRequest extends Model
{
    /**
     * @var string
     */
    public $bizId;

    /**
     * @var string
     */
    public $companyId;

    /**
     * @var int
     */
    public $contractAmount;

    /**
     * @var string
     */
    public $contractType;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $creditCode;

    /**
     * @var string
     */
    public $from;

    /**
     * @var string
     */
    public $registrationNumber;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $staffId;

    /**
     * @var string
     */
    public $subjectName;
    protected $_name = [
        'bizId' => 'bizId',
        'companyId' => 'companyId',
        'contractAmount' => 'contractAmount',
        'contractType' => 'contractType',
        'corpId' => 'corpId',
        'creditCode' => 'creditCode',
        'from' => 'from',
        'registrationNumber' => 'registrationNumber',
        'staffId' => 'staffId',
        'subjectName' => 'subjectName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->companyId) {
            $res['companyId'] = $this->companyId;
        }
        if (null !== $this->contractAmount) {
            $res['contractAmount'] = $this->contractAmount;
        }
        if (null !== $this->contractType) {
            $res['contractType'] = $this->contractType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->creditCode) {
            $res['creditCode'] = $this->creditCode;
        }
        if (null !== $this->from) {
            $res['from'] = $this->from;
        }
        if (null !== $this->registrationNumber) {
            $res['registrationNumber'] = $this->registrationNumber;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QuerySubjectPublicRiskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['companyId'])) {
            $model->companyId = $map['companyId'];
        }
        if (isset($map['contractAmount'])) {
            $model->contractAmount = $map['contractAmount'];
        }
        if (isset($map['contractType'])) {
            $model->contractType = $map['contractType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['creditCode'])) {
            $model->creditCode = $map['creditCode'];
        }
        if (isset($map['from'])) {
            $model->from = $map['from'];
        }
        if (isset($map['registrationNumber'])) {
            $model->registrationNumber = $map['registrationNumber'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }

        return $model;
    }
}
