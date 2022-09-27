<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\SearchResponseBody\dentryResult;

use AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\OpenActionModel;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @description 如果内容命中了关键词，会返回该部分内容，带高亮。
     *
     * @var string
     */
    public $content;

    /**
     * @description 创建信息。
     *
     * @var OpenActionModel
     */
    public $creation;

    /**
     * @description 节点id。
     *
     * @var string
     */
    public $dentryId;

    /**
     * @description 节点唯一标识。
     *
     * @var string
     */
    public $dentryUuid;

    /**
     * @description 文件名扩展。
     *
     * @var string
     */
    public $extension;

    /**
     * @description 节点图标url。
     *
     * @var string
     */
    public $iconUrl;

    /**
     * @description 最后修改信息。
     *
     * @var OpenActionModel
     */
    public $lastEdition;

    /**
     * @description 节点名称，如果命中了关键词，会带有高亮。
     *
     * @var string
     */
    public $name;

    /**
     * @description 节点原始名称，不带高亮。
     *
     * @var string
     */
    public $originName;

    /**
     * @description 节点的路径。
     *
     * @var string
     */
    public $path;

    /**
     * @description 节点所属的业务场景。可选值有：1-知识库；2-我的文档；5-群聊。
     *
     * @var int
     */
    public $sceneType;

    /**
     * @description 文件类型。1-文档；2-表格；3-脑图；4-演示；5-白板；6-office文字；7-office表格；8-office ppt；10-多维表格；11-文本；12-图片；13-视频；14-音频；15-压缩文件；16-其他。
     *
     * @var int
     */
    public $searchFileType;

    /**
     * @description 节点所属的知识库id。
     *
     * @var string
     */
    public $spaceId;

    /**
     * @description 文档缩略图url。
     *
     * @var string
     */
    public $thumbnailUrl;

    /**
     * @description 节点访问url。
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'content'        => 'content',
        'creation'       => 'creation',
        'dentryId'       => 'dentryId',
        'dentryUuid'     => 'dentryUuid',
        'extension'      => 'extension',
        'iconUrl'        => 'iconUrl',
        'lastEdition'    => 'lastEdition',
        'name'           => 'name',
        'originName'     => 'originName',
        'path'           => 'path',
        'sceneType'      => 'sceneType',
        'searchFileType' => 'searchFileType',
        'spaceId'        => 'spaceId',
        'thumbnailUrl'   => 'thumbnailUrl',
        'url'            => 'url',
    ];

    public function validate()
    {
    }

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
