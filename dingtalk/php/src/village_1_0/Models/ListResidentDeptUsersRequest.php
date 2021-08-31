<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListResidentDeptUsersRequest extends Model
{
    /**
     * @description 下属组织的组织ID，比如下属镇、村的corpId
     *
     * @var string
     */
    public $subCorpId;

    /**
     * @description 角色标签
     *
     * @var string
     */
    public $role;

    /**
     * @description 游标，不传默认1
     *
     * @var int
     */
    public $cursor;

    /**
     * @description 大小
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'subCorpId' => 'subCorpId',
        'role'      => 'role',
        'cursor'    => 'cursor',
        'size'      => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
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
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
