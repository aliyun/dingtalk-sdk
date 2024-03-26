<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportAwardDetailRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $awardDate;

    /**
     * @var string
     */
    public $awardName;

    /**
     * @var string
     */
    public $awardOrg;

    /**
     * @var string
     */
    public $awardType;

    /**
     * @var string
     */
    public $comment;

    /**
     * @var mixed[]
     */
    public $extendInfo;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'awardDate'  => 'awardDate',
        'awardName'  => 'awardName',
        'awardOrg'   => 'awardOrg',
        'awardType'  => 'awardType',
        'comment'    => 'comment',
        'extendInfo' => 'extendInfo',
        'name'       => 'name',
        'workNo'     => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->awardDate) {
            $res['awardDate'] = $this->awardDate;
        }
        if (null !== $this->awardName) {
            $res['awardName'] = $this->awardName;
        }
        if (null !== $this->awardOrg) {
            $res['awardOrg'] = $this->awardOrg;
        }
        if (null !== $this->awardType) {
            $res['awardType'] = $this->awardType;
        }
        if (null !== $this->comment) {
            $res['comment'] = $this->comment;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
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
        if (isset($map['awardDate'])) {
            $model->awardDate = $map['awardDate'];
        }
        if (isset($map['awardName'])) {
            $model->awardName = $map['awardName'];
        }
        if (isset($map['awardOrg'])) {
            $model->awardOrg = $map['awardOrg'];
        }
        if (isset($map['awardType'])) {
            $model->awardType = $map['awardType'];
        }
        if (isset($map['comment'])) {
            $model->comment = $map['comment'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
