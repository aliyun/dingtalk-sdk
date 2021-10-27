<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddKnowledgeRequest\attachmentList;
use AlibabaCloud\Tea\Model;

class AddKnowledgeRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @description 开放团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 知识库的唯一标识
     *
     * @var string
     */
    public $libraryKey;

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
     * @description 知识点类型 NORMAL：普通型 CARD：卡片 CONDITION：条件
     *
     * @var string
     */
    public $type;

    /**
     * @description 知识点名称
     *
     * @var string
     */
    public $title;

    /**
     * @description 知识点内容
     *
     * @var string
     */
    public $content;

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
     * @description 附件列表
     *
     * @var attachmentList[]
     */
    public $attachmentList;

    /**
     * @description CCM的知识点外链
     *
     * @var string
     */
    public $linkUrl;

    /**
     * @description 知识点版本号
     *
     * @var string
     */
    public $version;
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingOrgId'          => 'dingOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'openTeamId'         => 'openTeamId',
        'libraryKey'         => 'libraryKey',
        'source'             => 'source',
        'sourcePrimaryKey'   => 'sourcePrimaryKey',
        'type'               => 'type',
        'title'              => 'title',
        'content'            => 'content',
        'extTitle'           => 'extTitle',
        'keyword'            => 'keyword',
        'attachmentList'     => 'attachmentList',
        'linkUrl'            => 'linkUrl',
        'version'            => 'version',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->libraryKey) {
            $res['libraryKey'] = $this->libraryKey;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->sourcePrimaryKey) {
            $res['sourcePrimaryKey'] = $this->sourcePrimaryKey;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->extTitle) {
            $res['extTitle'] = $this->extTitle;
        }
        if (null !== $this->keyword) {
            $res['keyword'] = $this->keyword;
        }
        if (null !== $this->attachmentList) {
            $res['attachmentList'] = [];
            if (null !== $this->attachmentList && \is_array($this->attachmentList)) {
                $n = 0;
                foreach ($this->attachmentList as $item) {
                    $res['attachmentList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->linkUrl) {
            $res['linkUrl'] = $this->linkUrl;
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
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['libraryKey'])) {
            $model->libraryKey = $map['libraryKey'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['sourcePrimaryKey'])) {
            $model->sourcePrimaryKey = $map['sourcePrimaryKey'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['extTitle'])) {
            $model->extTitle = $map['extTitle'];
        }
        if (isset($map['keyword'])) {
            $model->keyword = $map['keyword'];
        }
        if (isset($map['attachmentList'])) {
            if (!empty($map['attachmentList'])) {
                $model->attachmentList = [];
                $n                     = 0;
                foreach ($map['attachmentList'] as $item) {
                    $model->attachmentList[$n++] = null !== $item ? attachmentList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['linkUrl'])) {
            $model->linkUrl = $map['linkUrl'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
