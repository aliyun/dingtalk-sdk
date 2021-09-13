<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddGroupMembersResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $memberUids;
    protected $_name = [
        'memberUids' => 'memberUids',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->memberUids) {
            $res['memberUids'] = $this->memberUids;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddGroupMembersResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['memberUids'])) {
            if (!empty($map['memberUids'])) {
                $model->memberUids = $map['memberUids'];
            }
        }

        return $model;
    }
}
