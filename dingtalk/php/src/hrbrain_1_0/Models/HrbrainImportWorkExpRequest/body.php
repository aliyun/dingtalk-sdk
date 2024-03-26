<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportWorkExpRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $companyName;

    /**
     * @var string
     */
    public $endDate;

    /**
     * @var mixed[]
     */
    public $extendInfo;

    /**
     * @var string
     */
    public $jobDesc;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $postName;

    /**
     * @var string
     */
    public $startDate;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'companyName' => 'companyName',
        'endDate'     => 'endDate',
        'extendInfo'  => 'extendInfo',
        'jobDesc'     => 'jobDesc',
        'name'        => 'name',
        'postName'    => 'postName',
        'startDate'   => 'startDate',
        'workNo'      => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->companyName) {
            $res['companyName'] = $this->companyName;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->jobDesc) {
            $res['jobDesc'] = $this->jobDesc;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->postName) {
            $res['postName'] = $this->postName;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
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
        if (isset($map['companyName'])) {
            $model->companyName = $map['companyName'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['jobDesc'])) {
            $model->jobDesc = $map['jobDesc'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['postName'])) {
            $model->postName = $map['postName'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
