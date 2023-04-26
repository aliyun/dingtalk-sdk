<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileUploadInfoRequest\option;

use AlibabaCloud\Tea\Model;

class preCheckParam extends Model
{
    /**
     * @example md5
     *
     * @var string
     */
    public $md5;

    /**
     * @example dentry_name
     *
     * @var string
     */
    public $name;

    /**
     * @example parent_id
     *
     * @var string
     */
    public $parentId;

    /**
     * @example 512
     *
     * @var int
     */
    public $size;
    protected $_name = [
        'md5'      => 'md5',
        'name'     => 'name',
        'parentId' => 'parentId',
        'size'     => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->md5) {
            $res['md5'] = $this->md5;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return preCheckParam
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['md5'])) {
            $model->md5 = $map['md5'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
