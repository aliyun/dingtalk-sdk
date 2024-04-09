<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchPublishDentriesResponseBody;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @example name
     *
     * @var string
     */
    public $name;

    /**
     * @example folderA/folderB
     *
     * @var string
     */
    public $path;

    /**
     * @example name
     *
     * @var string
     */
    public $summary;

    /**
     * @example url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'name'    => 'name',
        'path'    => 'path',
        'summary' => 'summary',
        'url'     => 'url',
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
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
