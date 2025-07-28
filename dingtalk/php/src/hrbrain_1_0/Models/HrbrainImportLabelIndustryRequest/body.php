<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportLabelIndustryRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var mixed[]
     */
    public $extendInfo;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $level1;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $level2;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $level3;

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
    public $workNo;
    protected $_name = [
        'extendInfo' => 'extendInfo',
        'level1' => 'level1',
        'level2' => 'level2',
        'level3' => 'level3',
        'name' => 'name',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->level1) {
            $res['level1'] = $this->level1;
        }
        if (null !== $this->level2) {
            $res['level2'] = $this->level2;
        }
        if (null !== $this->level3) {
            $res['level3'] = $this->level3;
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
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['level1'])) {
            $model->level1 = $map['level1'];
        }
        if (isset($map['level2'])) {
            $model->level2 = $map['level2'];
        }
        if (isset($map['level3'])) {
            $model->level3 = $map['level3'];
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
