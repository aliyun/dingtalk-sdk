<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelDataQueryResponseBody\content;

use AlibabaCloud\Tea\Model;

class labelDatas extends Model
{
    /**
     * @var string
     */
    public $deptName;

    /**
     * @var string
     */
    public $deptNo;

    /**
     * @var string
     */
    public $jobLevel;

    /**
     * @var string
     */
    public $labelTitle;

    /**
     * @var string
     */
    public $labelValue;

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
    public $workNo;
    protected $_name = [
        'deptName' => 'deptName',
        'deptNo' => 'deptNo',
        'jobLevel' => 'jobLevel',
        'labelTitle' => 'labelTitle',
        'labelValue' => 'labelValue',
        'name' => 'name',
        'postName' => 'postName',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptNo) {
            $res['deptNo'] = $this->deptNo;
        }
        if (null !== $this->jobLevel) {
            $res['jobLevel'] = $this->jobLevel;
        }
        if (null !== $this->labelTitle) {
            $res['labelTitle'] = $this->labelTitle;
        }
        if (null !== $this->labelValue) {
            $res['labelValue'] = $this->labelValue;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->postName) {
            $res['postName'] = $this->postName;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return labelDatas
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptNo'])) {
            $model->deptNo = $map['deptNo'];
        }
        if (isset($map['jobLevel'])) {
            $model->jobLevel = $map['jobLevel'];
        }
        if (isset($map['labelTitle'])) {
            $model->labelTitle = $map['labelTitle'];
        }
        if (isset($map['labelValue'])) {
            $model->labelValue = $map['labelValue'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['postName'])) {
            $model->postName = $map['postName'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
