<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetCorpAccomplishmentTasksRequest extends Model
{
    /**
     * @description 应用标识列表
     *
     * @var string
     */
    public $appTypes;

    /**
     * @description 创建时间开始
     *
     * @var int
     */
    public $createFromTimeGMT;

    /**
     * @description 创建时间结束
     *
     * @var int
     */
    public $createToTimeGMT;

    /**
     * @description 关键词
     *
     * @var string
     */
    public $keyword;

    /**
     * @description 语言环境
     *
     * @var string
     */
    public $language;

    /**
     * @description 当前页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 每页记录数
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 流程code列表
     *
     * @var string
     */
    public $processCodes;

    /**
     * @description 验权token
     *
     * @var string
     */
    public $token;
    protected $_name = [
        'appTypes'          => 'appTypes',
        'createFromTimeGMT' => 'createFromTimeGMT',
        'createToTimeGMT'   => 'createToTimeGMT',
        'keyword'           => 'keyword',
        'language'          => 'language',
        'pageNumber'        => 'pageNumber',
        'pageSize'          => 'pageSize',
        'processCodes'      => 'processCodes',
        'token'             => 'token',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appTypes) {
            $res['appTypes'] = $this->appTypes;
        }
        if (null !== $this->createFromTimeGMT) {
            $res['createFromTimeGMT'] = $this->createFromTimeGMT;
        }
        if (null !== $this->createToTimeGMT) {
            $res['createToTimeGMT'] = $this->createToTimeGMT;
        }
        if (null !== $this->keyword) {
            $res['keyword'] = $this->keyword;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->processCodes) {
            $res['processCodes'] = $this->processCodes;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetCorpAccomplishmentTasksRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appTypes'])) {
            $model->appTypes = $map['appTypes'];
        }
        if (isset($map['createFromTimeGMT'])) {
            $model->createFromTimeGMT = $map['createFromTimeGMT'];
        }
        if (isset($map['createToTimeGMT'])) {
            $model->createToTimeGMT = $map['createToTimeGMT'];
        }
        if (isset($map['keyword'])) {
            $model->keyword = $map['keyword'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['processCodes'])) {
            $model->processCodes = $map['processCodes'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }

        return $model;
    }
}
