<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListResidentDeptUsersRequest extends Model
{
    /**
     * @description 游标，不传默认1
     *
     * @var int
     */
    public $cursor;

    /**
     * @description 角色标签
     *
     * @var string
     */
    public $role;

    /**
     * @description 大小
     *
     * @var int
     */
    public $size;

    /**
     * @description 下属组织的组织ID，比如下属镇、村的corpId
     *
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
