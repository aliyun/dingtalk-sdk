<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\dentryResult;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\OpenActionModel;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var OpenActionModel
     */
    public $creation;

    /**
     * @var string
     */
    public $dentryId;

    /**
     * @var string
     */
    public $dentryUuid;

    /**
     * @var string
     */
    public $extension;

    /**
     * @var string
     */
    public $iconUrl;

    /**
     * @var OpenActionModel
     */
    public $lastEdition;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $originName;

    /**
     * @var string
     */
    public $path;

    /**
     * @example 1
     *
     * @var int
     */
    public $sceneType;

    /**
     * @var int
     */
    public $searchFileType;

    /**
     * @var string
     */
    public $spaceId;

    /**
     * @var string
     */
    public $thumbnailUrl;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'content' => 'content',
        'creation' => 'creation',
        'dentryId' => 'dentryId',
        'dentryUuid' => 'dentryUuid',
        'extension' => 'extension',
        'iconUrl' => 'iconUrl',
        'lastEdition' => 'lastEdition',
        'name' => 'name',
        'originName' => 'originName',
        'path' => 'path',
        'sceneType' => 'sceneType',
        'searchFileType' => 'searchFileType',
        'spaceId' => 'spaceId',
        'thumbnailUrl' => 'thumbnailUrl',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->creation) {
            $res['creation'] = null !== $this->creation ? $this->creation->toMap() : null;
        }
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }
        if (null !== $this->lastEdition) {
            $res['lastEdition'] = null !== $this->lastEdition ? $this->lastEdition->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->originName) {
            $res['originName'] = $this->originName;
        }
        if (null !== $this->path) {
            $res['path'] = $this->path;
        }
        if (null !== $this->sceneType) {
            $res['sceneType'] = $this->sceneType;
        }
        if (null !== $this->searchFileType) {
            $res['searchFileType'] = $this->searchFileType;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->thumbnailUrl) {
            $res['thumbnailUrl'] = $this->thumbnailUrl;
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
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['creation'])) {
            $model->creation = OpenActionModel::fromMap($map['creation']);
        }
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }
        if (isset($map['lastEdition'])) {
            $model->lastEdition = OpenActionModel::fromMap($map['lastEdition']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['originName'])) {
            $model->originName = $map['originName'];
        }
        if (isset($map['path'])) {
            $model->path = $map['path'];
        }
        if (isset($map['sceneType'])) {
            $model->sceneType = $map['sceneType'];
        }
        if (isset($map['searchFileType'])) {
            $model->searchFileType = $map['searchFileType'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['thumbnailUrl'])) {
            $model->thumbnailUrl = $map['thumbnailUrl'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
