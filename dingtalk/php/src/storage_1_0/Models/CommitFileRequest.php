<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CommitFileRequest\option;
use AlibabaCloud\Tea\Model;

class CommitFileRequest extends Model
{
    /**
     * @example dentry_name
     *
     * @var string
     */
    public $name;

    /**
     * @var option
     */
    public $option;

    /**
     * @example parent_id
     *
     * @var string
     */
    public $parentId;

    /**
     * @example upload_key
     *
     * @var string
     */
    public $uploadKey;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'name'      => 'name',
        'option'    => 'option',
        'parentId'  => 'parentId',
        'uploadKey' => 'uploadKey',
        'unionId'   => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->option) {
            $res['option'] = null !== $this->option ? $this->option->toMap() : null;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->uploadKey) {
            $res['uploadKey'] = $this->uploadKey;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CommitFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['option'])) {
            $model->option = option::fromMap($map['option']);
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['uploadKey'])) {
            $model->uploadKey = $map['uploadKey'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
