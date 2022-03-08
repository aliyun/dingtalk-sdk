<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenKnowledgeRequest;

use AlibabaCloud\Tea\Model;

class attachments extends Model
{
    /**
     * @description 媒体类型(扩展名大写)
     *
     * @var string
     */
    public $mimeType;

    /**
     * @description 附件URL
     *
     * @var string
     */
    public $path;

    /**
     * @description 附件大小
     *
     * @var float
     */
    public $size;

    /**
     * @description 扩展名
     *
     * @var string
     */
    public $suffix;

    /**
     * @description 附件名称
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'mimeType' => 'mimeType',
        'path'     => 'path',
        'size'     => 'size',
        'suffix'   => 'suffix',
        'title'    => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mimeType) {
            $res['mimeType'] = $this->mimeType;
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
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attachments
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mimeType'])) {
            $model->mimeType = $map['mimeType'];
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
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
