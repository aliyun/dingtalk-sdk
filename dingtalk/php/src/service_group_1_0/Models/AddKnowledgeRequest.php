<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddKnowledgeRequest\attachmentList;
use AlibabaCloud\Tea\Model;

class AddKnowledgeRequest extends Model
{
    /**
     * @description 附件列表
     *
     * @var attachmentList[]
     */
    public $attachmentList;

    /**
     * @description 知识点内容
     *
     * @var string
     */
    public $content;

    /**
     * @var int
     */
    public $effectTimeend;

    /**
     * @var int
     */
    public $effectTimestart;

    /**
     * @description 知识点扩展问(多个用英文逗号隔开)
     *
     * @var string
     */
    public $extTitle;

    /**
     * @description 关键字(多个用英文逗号隔开)
     *
     * @var string
     */
    public $keyword;

    /**
     * @description 知识库的唯一标识
     *
     * @var string
     */
    public $libraryKey;

    /**
     * @description CCM的知识点外链
     *
     * @var string
     */
    public $linkUrl;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 关联问题id
     *
     * @var int[]
     */
    public $questionIds;

    /**
     * @description 知识点来源
     *
     * @var string
     */
    public $source;

    /**
     * @description 知识点唯一标识
     *
     * @var string
     */
    public $sourcePrimaryKey;

    /**
     * @description 知识点名称
     *
     * @var string
     */
    public $title;

    /**
     * @description 知识点类型 NORMAL：普通型 CARD：卡片 CONDITION：条件
     *
     * @var string
     */
    public $type;

    /**
     * @description 知识点版本号
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'attachmentList'   => 'attachmentList',
        'content'          => 'content',
        'effectTimeend'    => 'effectTimeend',
        'effectTimestart'  => 'effectTimestart',
        'extTitle'         => 'extTitle',
        'keyword'          => 'keyword',
        'libraryKey'       => 'libraryKey',
        'linkUrl'          => 'linkUrl',
        'openTeamId'       => 'openTeamId',
        'questionIds'      => 'questionIds',
        'source'           => 'source',
        'sourcePrimaryKey' => 'sourcePrimaryKey',
        'title'            => 'title',
        'type'             => 'type',
        'version'          => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachmentList) {
            $res['attachmentList'] = [];
            if (null !== $this->attachmentList && \is_array($this->attachmentList)) {
                $n = 0;
                foreach ($this->attachmentList as $item) {
                    $res['attachmentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->effectTimeend) {
            $res['effectTimeend'] = $this->effectTimeend;
        }
        if (null !== $this->effectTimestart) {
            $res['effectTimestart'] = $this->effectTimestart;
        }
        if (null !== $this->extTitle) {
            $res['extTitle'] = $this->extTitle;
        }
        if (null !== $this->keyword) {
            $res['keyword'] = $this->keyword;
        }
        if (null !== $this->libraryKey) {
            $res['libraryKey'] = $this->libraryKey;
        }
        if (null !== $this->linkUrl) {
            $res['linkUrl'] = $this->linkUrl;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->questionIds) {
            $res['questionIds'] = $this->questionIds;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->sourcePrimaryKey) {
            $res['sourcePrimaryKey'] = $this->sourcePrimaryKey;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->version) {
            $res['version'] = $this->version;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddKnowledgeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachmentList'])) {
            if (!empty($map['attachmentList'])) {
                $model->attachmentList = [];
                $n                     = 0;
                foreach ($map['attachmentList'] as $item) {
                    $model->attachmentList[$n++] = null !== $item ? attachmentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['effectTimeend'])) {
            $model->effectTimeend = $map['effectTimeend'];
        }
        if (isset($map['effectTimestart'])) {
            $model->effectTimestart = $map['effectTimestart'];
        }
        if (isset($map['extTitle'])) {
            $model->extTitle = $map['extTitle'];
        }
        if (isset($map['keyword'])) {
            $model->keyword = $map['keyword'];
        }
        if (isset($map['libraryKey'])) {
            $model->libraryKey = $map['libraryKey'];
        }
        if (isset($map['linkUrl'])) {
            $model->linkUrl = $map['linkUrl'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['questionIds'])) {
            if (!empty($map['questionIds'])) {
                $model->questionIds = $map['questionIds'];
            }
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['sourcePrimaryKey'])) {
            $model->sourcePrimaryKey = $map['sourcePrimaryKey'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
