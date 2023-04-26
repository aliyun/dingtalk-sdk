<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeUpdateStudentInfoRequest extends Model
{
    /**
     * @example "city":"beijing"
     *
     * @var string[]
     */
    public $empExtension;

    /**
     * @example male
     *
     * @var string
     */
    public $gender;

    /**
     * @example 11019xxxxxx0001
     *
     * @var string
     */
    public $identifyId;

    /**
     * @example 2015
     *
     * @var string
     */
    public $startYear;

    /**
     * @example 1111111
     *
     * @var int
     */
    public $studentId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $studentName;
    protected $_name = [
        'empExtension' => 'empExtension',
        'gender'       => 'gender',
        'identifyId'   => 'identifyId',
        'startYear'    => 'startYear',
        'studentId'    => 'studentId',
        'studentName'  => 'studentName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->empExtension) {
            $res['empExtension'] = $this->empExtension;
        }
        if (null !== $this->gender) {
            $res['gender'] = $this->gender;
        }
        if (null !== $this->identifyId) {
            $res['identifyId'] = $this->identifyId;
        }
        if (null !== $this->startYear) {
            $res['startYear'] = $this->startYear;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }
        if (null !== $this->studentName) {
            $res['studentName'] = $this->studentName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeUpdateStudentInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['empExtension'])) {
            $model->empExtension = $map['empExtension'];
        }
        if (isset($map['gender'])) {
            $model->gender = $map['gender'];
        }
        if (isset($map['identifyId'])) {
            $model->identifyId = $map['identifyId'];
        }
        if (isset($map['startYear'])) {
            $model->startYear = $map['startYear'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }
        if (isset($map['studentName'])) {
            $model->studentName = $map['studentName'];
        }

        return $model;
    }
}
