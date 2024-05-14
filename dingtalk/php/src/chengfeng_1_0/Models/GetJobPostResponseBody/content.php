<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetJobPostResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @example 123
     *
     * @var string
     */
    public $code;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $establishDate;

    /**
     * @example 测试
     *
     * @var string
     */
    public $name;

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
    public $stopDate;
    protected $_name = [
        'code'          => 'code',
        'establishDate' => 'establishDate',
        'name'          => 'name',
        'startDate'     => 'startDate',
        'stopDate'      => 'stopDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->establishDate) {
            $res['establishDate'] = $this->establishDate;
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
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['establishDate'])) {
            $model->establishDate = $map['establishDate'];
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
