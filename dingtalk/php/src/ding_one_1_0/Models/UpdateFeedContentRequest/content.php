<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\UpdateFeedContentRequest;

use AlibabaCloud\SDK\Dingtalk\Vding_one_1_0\Models\UpdateFeedContentRequest\content\dslTemplateContent;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example dslTemplate
     *
     * @var string
     */
    public $contentType;

    /**
     * @description This parameter is required.
     *
     * @var dslTemplateContent
     */
    public $dslTemplateContent;
    protected $_name = [
        'contentType' => 'contentType',
        'dslTemplateContent' => 'dslTemplateContent',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->dslTemplateContent) {
            $res['dslTemplateContent'] = null !== $this->dslTemplateContent ? $this->dslTemplateContent->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['dslTemplateContent'])) {
            $model->dslTemplateContent = dslTemplateContent::fromMap($map['dslTemplateContent']);
        }

        return $model;
    }
}
