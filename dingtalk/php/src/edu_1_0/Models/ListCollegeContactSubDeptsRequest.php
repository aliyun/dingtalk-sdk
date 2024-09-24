<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListCollegeContactSubDeptsRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 200
     *
     * @var int
     */
    public $deptId;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;
    protected $_name = [
        'deptId'   => 'deptId',
        'language' => 'language',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListCollegeContactSubDeptsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }

        return $model;
    }
}
