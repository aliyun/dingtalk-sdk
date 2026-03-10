<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\dingHelperDocs\ableDashboardModel;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\dingHelperDocs\scoreItem;
use AlibabaCloud\Tea\Model;

class dingHelperDocs extends Model
{
    /**
     * @var ableDashboardModel
     */
    public $ableDashboardModel;

    /**
     * @var int
     */
    public $chunkId;

    /**
     * @var int[]
     */
    public $chunkIds;

    /**
     * @var string
     */
    public $chunkModel;

    /**
     * @var string
     */
    public $creator;

    /**
     * @var string
     */
    public $dentryUuid;

    /**
     * @var string
     */
    public $extension;

    /**
     * @var int
     */
    public $gmtCreate;

    /**
     * @var int
     */
    public $gmtModified;

    /**
     * @var bool
     */
    public $hasExtendChunk;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var bool
     */
    public $matchIntimacy;

    /**
     * @var string
     */
    public $material;

    /**
     * @var string
     */
    public $refType;

    /**
     * @var float
     */
    public $score;

    /**
     * @var scoreItem
     */
    public $scoreItem;

    /**
     * @var string
     */
    public $small2bigText;

    /**
     * @var string
     */
    public $text;

    /**
     * @var int
     */
    public $timestamp;

    /**
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $type;

    /**
     * @var string
     */
    public $uploadSource;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'ableDashboardModel' => 'ableDashboardModel',
        'chunkId' => 'chunkId',
        'chunkIds' => 'chunkIds',
        'chunkModel' => 'chunkModel',
        'creator' => 'creator',
        'dentryUuid' => 'dentryUuid',
        'extension' => 'extension',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'hasExtendChunk' => 'hasExtendChunk',
        'icon' => 'icon',
        'matchIntimacy' => 'matchIntimacy',
        'material' => 'material',
        'refType' => 'refType',
        'score' => 'score',
        'scoreItem' => 'scoreItem',
        'small2bigText' => 'small2bigText',
        'text' => 'text',
        'timestamp' => 'timestamp',
        'title' => 'title',
        'type' => 'type',
        'uploadSource' => 'uploadSource',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->ableDashboardModel) {
            $res['ableDashboardModel'] = null !== $this->ableDashboardModel ? $this->ableDashboardModel->toMap() : null;
        }
        if (null !== $this->chunkId) {
            $res['chunkId'] = $this->chunkId;
        }
        if (null !== $this->chunkIds) {
            $res['chunkIds'] = $this->chunkIds;
        }
        if (null !== $this->chunkModel) {
            $res['chunkModel'] = $this->chunkModel;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->dentryUuid) {
            $res['dentryUuid'] = $this->dentryUuid;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->hasExtendChunk) {
            $res['hasExtendChunk'] = $this->hasExtendChunk;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->matchIntimacy) {
            $res['matchIntimacy'] = $this->matchIntimacy;
        }
        if (null !== $this->material) {
            $res['material'] = $this->material;
        }
        if (null !== $this->refType) {
            $res['refType'] = $this->refType;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }
        if (null !== $this->scoreItem) {
            $res['scoreItem'] = null !== $this->scoreItem ? $this->scoreItem->toMap() : null;
        }
        if (null !== $this->small2bigText) {
            $res['small2bigText'] = $this->small2bigText;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->uploadSource) {
            $res['uploadSource'] = $this->uploadSource;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return dingHelperDocs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['ableDashboardModel'])) {
            $model->ableDashboardModel = ableDashboardModel::fromMap($map['ableDashboardModel']);
        }
        if (isset($map['chunkId'])) {
            $model->chunkId = $map['chunkId'];
        }
        if (isset($map['chunkIds'])) {
            if (!empty($map['chunkIds'])) {
                $model->chunkIds = $map['chunkIds'];
            }
        }
        if (isset($map['chunkModel'])) {
            $model->chunkModel = $map['chunkModel'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['dentryUuid'])) {
            $model->dentryUuid = $map['dentryUuid'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['hasExtendChunk'])) {
            $model->hasExtendChunk = $map['hasExtendChunk'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['matchIntimacy'])) {
            $model->matchIntimacy = $map['matchIntimacy'];
        }
        if (isset($map['material'])) {
            $model->material = $map['material'];
        }
        if (isset($map['refType'])) {
            $model->refType = $map['refType'];
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }
        if (isset($map['scoreItem'])) {
            $model->scoreItem = scoreItem::fromMap($map['scoreItem']);
        }
        if (isset($map['small2bigText'])) {
            $model->small2bigText = $map['small2bigText'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['uploadSource'])) {
            $model->uploadSource = $map['uploadSource'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
