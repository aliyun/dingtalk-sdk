<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateStudentClassRequest;

use AlibabaCloud\Tea\Model;

class studentList extends Model
{
    /**
     * @example {""}
     *
     * @var string
     */
    public $attributes;

    /**
     * @example studentxxx
     *
     * @var string
     */
    public $studentUserId;
    protected $_name = [
        'attributes'    => 'attributes',
        'studentUserId' => 'studentUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attributes) {
            $res['attributes'] = $this->attributes;
        }
        if (null !== $this->studentUserId) {
            $res['studentUserId'] = $this->studentUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return studentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attributes'])) {
            $model->attributes = $map['attributes'];
        }
        if (isset($map['studentUserId'])) {
            $model->studentUserId = $map['studentUserId'];
        }

        return $model;
    }
}
