<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrieveResponseBody\result\reports\scoreItem;
use AlibabaCloud\Tea\Model;

class reports extends Model
{
    /**
     * @var string
     */
    public $content;

    /**
     * @var int
     */
    public $corpId;

    /**
     * @var string
     */
    public $creator;

    /**
     * @var int
     */
    public $gmtCreate;

    /**
     * @var int
     */
    public $gmtModified;

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
    public $url;
    protected $_name = [
        'content' => 'content',
        'corpId' => 'corpId',
        'creator' => 'creator',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'icon' => 'icon',
        'matchIntimacy' => 'matchIntimacy',
        'material' => 'material',
        'refType' => 'refType',
        'score' => 'score',
        'scoreItem' => 'scoreItem',
        'timestamp' => 'timestamp',
        'title' => 'title',
        'type' => 'type',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
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
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return reports
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
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
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
