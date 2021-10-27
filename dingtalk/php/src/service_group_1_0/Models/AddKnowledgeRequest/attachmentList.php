<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddKnowledgeRequest;

use AlibabaCloud\Tea\Model;

class attachmentList extends Model
{
    /**
     * @description 附件名称
     *
     * @var string
     */
    public $title;

    /**
     * @description 附件URL
     *
     * @var string
     */
    public $path;

    /**
     * @description 附件大小
     *
     * @var int
     */
    public $size;

    /**
     * @description 附件扩展名
     *
     * @var string
     */
    public $suffix;

    /**
     * @description 多媒体类型
     *
     * @var string
     */
    public $mimeType;
    protected $_name = [
        'title'    => 'title',
        'path'     => 'path',
        'size'     => 'size',
        'suffix'   => 'suffix',
        'mimeType' => 'mime_type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->suffix) {
            $res['suffix'] = $this->suffix;
        }
        if (null !== $this->mimeType) {
            $res['mime_type'] = $this->mimeType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attachmentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['suffix'])) {
            $model->suffix = $map['suffix'];
        }
        if (isset($map['mime_type'])) {
            $model->mimeType = $map['mime_type'];
        }

        return $model;
    }
}
