<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\ListStarsResponseBody\starList;

use AlibabaCloud\Tea\Model;

class resource extends Model
{
    /**
     * @var string
     */
    public $contentType;

    /**
     * @var string
     */
    public $dentryType;

    /**
     * @var string
     */
    public $dentryUuid;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'contentType' => 'contentType',
        'dentryType' => 'dentryType',
        'dentryUuid' => 'dentryUuid',
        'name' => 'name',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->dentryType) {
            $res['dentryType'] = $this->dentryType;
        }
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return resource
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['dentryType'])) {
            $model->dentryType = $map['dentryType'];
        }
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
