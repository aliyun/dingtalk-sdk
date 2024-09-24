<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\AddCollegeContactUserRequest;

use AlibabaCloud\Tea\Model;

class deptTitleList extends Model
{
    /**
     * @example 123456
     *
     * @var int
     */
    public $deptId;

    /**
     * @example 学工处处长
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'deptId' => 'deptId',
        'title'  => 'title',
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
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return deptTitleList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
