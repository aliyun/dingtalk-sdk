<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTaskNoteRequest extends Model
{
    /**
     * @example 更改后的备注
     *
     * @var string
     */
    public $note;
    protected $_name = [
        'note' => 'note',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTaskNoteRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }

        return $model;
    }
}
