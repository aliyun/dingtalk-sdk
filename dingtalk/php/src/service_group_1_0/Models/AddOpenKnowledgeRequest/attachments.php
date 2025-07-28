<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenKnowledgeRequest;

use AlibabaCloud\Tea\Model;

class attachments extends Model
{
    /**
     * @example PDF
     *
     * @var string
     */
    public $mimeType;

    /**
     * @example https://dtapp-pub.dingtalk.com/dingtalkdesktop/test.pdf
     *
     * @var string
     */
    public $path;

    /**
     * @example 444556
     *
     * @var float
     */
    public $size;

    /**
     * @example pdf
     *
     * @var string
     */
    public $suffix;

    /**
     * @example 这是一个附件文档
     *
     * @var string
     */
    public $title;
    protected $_name = [
        'mimeType' => 'mimeType',
        'path' => 'path',
        'size' => 'size',
        'suffix' => 'suffix',
        'title' => 'title',
    ];

    public function validate() {}

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
