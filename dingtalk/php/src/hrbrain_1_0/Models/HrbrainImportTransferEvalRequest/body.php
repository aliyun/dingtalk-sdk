<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTransferEvalRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var mixed[]
     */
    public $currInfo;

    /**
     * @var mixed[]
     */
    public $extendInfo;

    /**
     * @var string
     */
    public $name;

    /**
     * @var mixed[]
     */
    public $preInfo;

    /**
     * @var string
     */
    public $transferDate;

    /**
     * @var string
     */
    public $transferReason;

    /**
     * @var string
     */
    public $transferType;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'currInfo'       => 'currInfo',
        'extendInfo'     => 'extendInfo',
        'name'           => 'name',
        'preInfo'        => 'preInfo',
        'transferDate'   => 'transferDate',
        'transferReason' => 'transferReason',
        'transferType'   => 'transferType',
        'workNo'         => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->currInfo) {
            $res['currInfo'] = $this->currInfo;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->preInfo) {
            $res['preInfo'] = $this->preInfo;
        }
        if (null !== $this->transferDate) {
            $res['transferDate'] = $this->transferDate;
        }
        if (null !== $this->transferReason) {
            $res['transferReason'] = $this->transferReason;
        }
        if (null !== $this->transferType) {
            $res['transferType'] = $this->transferType;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['currInfo'])) {
            $model->currInfo = $map['currInfo'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['preInfo'])) {
            $model->preInfo = $map['preInfo'];
        }
        if (isset($map['transferDate'])) {
            $model->transferDate = $map['transferDate'];
        }
        if (isset($map['transferReason'])) {
            $model->transferReason = $map['transferReason'];
        }
        if (isset($map['transferType'])) {
            $model->transferType = $map['transferType'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
