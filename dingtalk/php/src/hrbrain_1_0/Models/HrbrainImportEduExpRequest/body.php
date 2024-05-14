<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportEduExpRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $eduName;

    /**
     * @description This parameter is required.
     *
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
    public $major;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $schoolName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $startDate;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'eduName'    => 'eduName',
        'endDate'    => 'endDate',
        'extendInfo' => 'extendInfo',
        'major'      => 'major',
        'name'       => 'name',
        'schoolName' => 'schoolName',
        'startDate'  => 'startDate',
        'workNo'     => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->eduName) {
            $res['eduName'] = $this->eduName;
        }
        if (null !== $this->endDate) {
            $res['endDate'] = $this->endDate;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->major) {
            $res['major'] = $this->major;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->schoolName) {
            $res['schoolName'] = $this->schoolName;
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
        if (isset($map['eduName'])) {
            $model->eduName = $map['eduName'];
        }
        if (isset($map['endDate'])) {
            $model->endDate = $map['endDate'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['major'])) {
            $model->major = $map['major'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['schoolName'])) {
            $model->schoolName = $map['schoolName'];
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
