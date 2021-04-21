<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

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
        if (isset($map['linkUrl'])) {
            $model->linkUrl = $map['linkUrl'];
        }
        if (isset($map['version'])) {
            $model->version = $map['version'];
        }

        return $model;
    }
}
