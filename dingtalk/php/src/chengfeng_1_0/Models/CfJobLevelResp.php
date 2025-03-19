<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CfJobLevelResp extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $level;

    /**
     * @description This parameter is required.
     *
     * @example P1
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @example 1639065600000
     *
     * @var string
     */
    public $startDate;

    /**
     * @description This parameter is required.
     *
     * @example 1652198400000
     *
     * @var string
     */
    public $stopDate;
    protected $_name = [
        'level' => 'level',
        'name' => 'name',
        'startDate' => 'startDate',
        'stopDate' => 'stopDate',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->level) {
            $res['level'] = $this->level;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->stopDate) {
            $res['stopDate'] = $this->stopDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CfJobLevelResp
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['level'])) {
            $model->level = $map['level'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['stopDate'])) {
            $model->stopDate = $map['stopDate'];
        }

        return $model;
    }
}
