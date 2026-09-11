<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\ListMinutesAttachmentsResponseBody;

use AlibabaCloud\Tea\Model;

class attachments extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var int
     */
    public $contentType;

    /**
     * @var string
     */
    public $downloadUrl;

    /**
     * @var int
     */
    public $noteId;

    /**
     * @var int
     */
    public $noteTime;

    /**
     * @var int
     */
    public $relativeTimeMs;

    /**
     * @var int
     */
    public $type;
    protected $_name = [
        'content' => 'content',
        'contentType' => 'contentType',
        'downloadUrl' => 'downloadUrl',
        'noteId' => 'noteId',
        'noteTime' => 'noteTime',
        'relativeTimeMs' => 'relativeTimeMs',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->noteId) {
            $res['noteId'] = $this->noteId;
        }
        if (null !== $this->noteTime) {
            $res['noteTime'] = $this->noteTime;
        }
        if (null !== $this->relativeTimeMs) {
            $res['relativeTimeMs'] = $this->relativeTimeMs;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['noteId'])) {
            $model->noteId = $map['noteId'];
        }
        if (isset($map['noteTime'])) {
            $model->noteTime = $map['noteTime'];
        }
        if (isset($map['relativeTimeMs'])) {
            $model->relativeTimeMs = $map['relativeTimeMs'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
