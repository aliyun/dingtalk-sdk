<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSimpleUsersByRoleRequest extends Model
{
    /**
     * @description cursor
     *
     * @var int
     */
    public $offset;

    /**
     * @description size
     *
     * @var int
     */
    public $size;

    /**
     * @description roleId
     *
     * @var int
     */
    public $roleId;

    /**
     * @description subCorpId
     *
     * @var string
     */
    public $subCorpId;
    protected $_name = [
        'offset'    => 'offset',
        'size'      => 'size',
        'roleId'    => 'roleId',
        'subCorpId' => 'subCorpId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->offset) {
            $res['offset'] = $this->offset;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }
        if (null !== $this->subCorpId) {
            $res['subCorpId'] = $this->subCorpId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSimpleUsersByRoleRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['offset'])) {
            $model->offset = $map['offset'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }
        if (isset($map['subCorpId'])) {
            $model->subCorpId = $map['subCorpId'];
        }

        return $model;
    }
}
