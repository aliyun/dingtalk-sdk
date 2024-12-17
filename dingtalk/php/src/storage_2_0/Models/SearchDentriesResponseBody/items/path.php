<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\SearchDentriesResponseBody\items;

use AlibabaCloud\Tea\Model;

class path extends Model
{
    /**
     * @example folderA/folderB
     *
     * @var string
     */
    public $longPath;

    /**
     * @example folderA:folderB
     *
     * @var string
     */
    public $path;

    /**
     * @example url
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'longPath' => 'longPath',
        'path'     => 'path',
        'url'      => 'url',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->longPath) {
            $res['longPath'] = $this->longPath;
        }
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return path
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['longPath'])) {
            $model->longPath = $map['longPath'];
        }
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
