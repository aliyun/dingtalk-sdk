<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CommitFileRequest\option;
use AlibabaCloud\Tea\Model;

class CommitFileRequest extends Model
{
    /**
     * @description 名称(文件名+后缀), 规则：
     * 1. 头尾不能包含空格，否则会自动去除
     * 2. 不能包含特殊字符，包括：制表符、*、"、<、>、|
     * 3. 不能以"."结尾
     * @var string
     */
    public $name;

    /**
     * @description 可选参数
     *
     * @var option
     */
    public $option;

    /**
     * @description 父目录id, 根目录id值为0
     *
     * @var string
     */
    public $parentId;

    /**
     * @description 添加文件唯一标识，可通过DentryService.getUploadInfo来生成
     *
     * @var string
     */
    public $uploadKey;

    /**
     * @description 用户id
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
