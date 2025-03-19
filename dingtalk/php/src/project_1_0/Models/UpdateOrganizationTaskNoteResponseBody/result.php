<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\UpdateOrganizationTaskNoteResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 我是一条备注哦
     *
     * @var string
     */
    public $note;

    /**
     * @example 2022-06-13T05:48:45.788Z
     *
     * @var string
     */
    public $updated;
    protected $_name = [
        'note' => 'note',
        'updated' => 'updated',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->note) {
            $res['note'] = $this->note;
        }
        if (null !== $this->updated) {
            $res['updated'] = $this->updated;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['note'])) {
            $model->note = $map['note'];
        }
        if (isset($map['updated'])) {
            $model->updated = $map['updated'];
        }

        return $model;
    }
}
