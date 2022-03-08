<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDefinitionResponseBody\originator;

use AlibabaCloud\Tea\Model;

class masterDataDepartments extends Model
{
    /**
     * @description deptName
     *
     * @var string
     */
    public $deptName;

    /**
     * @description deptNameEn
     *
     * @var string
     */
    public $deptNameInEnglish;

    /**
     * @description deptNo
     *
     * @var string
     */
    public $deptNo;

    /**
     * @description deptPath
     *
     * @var string
     */
    public $deptPath;

    /**
     * @description humanSourceGroupOrderNum
     *
     * @var string
     */
    public $humanSourceGroupOrderNumber;

    /**
     * @description humanSourceGroupWorkNo
     *
     * @var string
     */
    public $humanSourceGroupWorkNo;

    /**
     * @description id
     *
     * @var int
     */
    public $id;

    /**
     * @description masterWorkNo
     *
     * @var string
     */
    public $masterWorkNo;
    protected $_name = [
        'deptName'                    => 'deptName',
        'deptNameInEnglish'           => 'deptNameInEnglish',
        'deptNo'                      => 'deptNo',
        'deptPath'                    => 'deptPath',
        'humanSourceGroupOrderNumber' => 'humanSourceGroupOrderNumber',
        'humanSourceGroupWorkNo'      => 'humanSourceGroupWorkNo',
        'id'                          => 'id',
        'masterWorkNo'                => 'masterWorkNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptNameInEnglish) {
            $res['deptNameInEnglish'] = $this->deptNameInEnglish;
        }
        if (null !== $this->deptNo) {
            $res['deptNo'] = $this->deptNo;
        }
        if (null !== $this->deptPath) {
            $res['deptPath'] = $this->deptPath;
        }
        if (null !== $this->humanSourceGroupOrderNumber) {
            $res['humanSourceGroupOrderNumber'] = $this->humanSourceGroupOrderNumber;
        }
        if (null !== $this->humanSourceGroupWorkNo) {
            $res['humanSourceGroupWorkNo'] = $this->humanSourceGroupWorkNo;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->masterWorkNo) {
            $res['masterWorkNo'] = $this->masterWorkNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return masterDataDepartments
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptNameInEnglish'])) {
            $model->deptNameInEnglish = $map['deptNameInEnglish'];
        }
        if (isset($map['deptNo'])) {
            $model->deptNo = $map['deptNo'];
        }
        if (isset($map['deptPath'])) {
            $model->deptPath = $map['deptPath'];
        }
        if (isset($map['humanSourceGroupOrderNumber'])) {
            $model->humanSourceGroupOrderNumber = $map['humanSourceGroupOrderNumber'];
        }
        if (isset($map['humanSourceGroupWorkNo'])) {
            $model->humanSourceGroupWorkNo = $map['humanSourceGroupWorkNo'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['masterWorkNo'])) {
            $model->masterWorkNo = $map['masterWorkNo'];
        }

        return $model;
    }
}
