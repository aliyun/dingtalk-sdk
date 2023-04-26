<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListResidentDeptUsersRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $cursor;

    /**
     * @var string
     */
    public $role;

    /**
     * @var int
     */
    public $size;

    /**
     * @var string
     */
    public $subCorpId;
    protected $_name = [
        'cursor'    => 'cursor',
        'role'      => 'role',
        'size'      => 'size',
        'subCorpId' => 'subCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListResidentDeptUsersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }

        return $model;
    }
}
