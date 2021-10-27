<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddOpenKnowledgeRequest\attachments;
use AlibabaCloud\Tea\Model;

class AddOpenKnowledgeRequest extends Model
{
    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @description 所属团队ID
     *
     * @var string
     */
    public $openTeamId;

    /**
     * @description 用户ID
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户昵称或姓名
     *
     * @var string
     */
    public $userName;

    /**
     * @description 附件列表
     *
     * @var attachments[]
     */
    public $attachments;

    /**
     * @description 所属知识库唯一标识id
     *
     * @var int
     */
    public $libraryId;

    /**
     * @description 知识点来源
     *
     * @var string
     */
    public $source;

    /**
     * @description 知识点标准问
     *
     * @var string
     */
    public $title;

    /**
     * @description 知识点类型()
     *
     * @var string
     */
    public $type;

    /**
     * @description 知识点正文
     *
     * @var string
     */
    public $content;

    /**
     * @description 扩展问法(多个英文逗号隔开)
     *
     * @var string
     */
    public $extTitle;

    /**
     * @description 关键词(多个逗号隔开)
     *
     * @var string
     */
    public $keyword;

    /**
     * @description 标签(多个可逗号隔开)
     *
     * @var string
     */
    public $tags;

    /**
     * @description 生效开始时间(默认1980-01-01 00:00:00)
     *
     * @var string
     */
    public $effectTimestart;

    /**
     * @description 生效结束时间(默认2100-01-01 23:59:59)
     *
     * @var string
     */
    public $effectTimeend;

    /**
     * @description 知识点所属类目ID
     *
     * @var int
     */
    public $categoryId;
    protected $_name = [
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingOrgId'          => 'dingOrgId',
        'openTeamId'         => 'openTeamId',
        'userId'             => 'userId',
        'userName'           => 'userName',
        'attachments'        => 'attachments',
        'libraryId'          => 'libraryId',
        'source'             => 'source',
        'title'              => 'title',
        'type'               => 'type',
        'content'            => 'content',
        'extTitle'           => 'extTitle',
        'keyword'            => 'keyword',
        'tags'               => 'tags',
        'effectTimestart'    => 'effectTimestart',
        'effectTimeend'      => 'effectTimeend',
        'categoryId'         => 'categoryId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->openTeamId) {
            $res['openTeamId'] = $this->openTeamId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->attachments) {
            $res['attachments'] = [];
            if (null !== $this->attachments && \is_array($this->attachments)) {
                $n = 0;
                foreach ($this->attachments as $item) {
                    $res['attachments'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->libraryId) {
            $res['libraryId'] = $this->libraryId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (null !== $this->tags) {
            $res['tags'] = $this->tags;
        }
        if (null !== $this->effectTimestart) {
            $res['effectTimestart'] = $this->effectTimestart;
        }
        if (null !== $this->effectTimeend) {
            $res['effectTimeend'] = $this->effectTimeend;
        }
        if (null !== $this->categoryId) {
            $res['categoryId'] = $this->categoryId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddOpenKnowledgeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['openTeamId'])) {
            $model->openTeamId = $map['openTeamId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['attachments'])) {
            if (!empty($map['attachments'])) {
                $model->attachments = [];
                $n                  = 0;
                foreach ($map['attachments'] as $item) {
                    $model->attachments[$n++] = null !== $item ? attachments::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['libraryId'])) {
            $model->libraryId = $map['libraryId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
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
        if (isset($map['tags'])) {
            $model->tags = $map['tags'];
        }
        if (isset($map['effectTimestart'])) {
            $model->effectTimestart = $map['effectTimestart'];
        }
        if (isset($map['effectTimeend'])) {
            $model->effectTimeend = $map['effectTimeend'];
        }
        if (isset($map['categoryId'])) {
            $model->categoryId = $map['categoryId'];
        }

        return $model;
    }
}
