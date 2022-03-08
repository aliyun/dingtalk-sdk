<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetNotifyMeRequest extends Model
{
    /**
     * @description 应用标识列表
     *
     * @var string
     */
    public $appTypes;

    /**
     * @description 企业ID
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 抄送到达时间开始
     *
     * @var int
     */
    public $createFromTimeGMT;

    /**
     * @description 抄送到达时间结束
     *
     * @var int
     */
    public $createToTimeGMT;

    /**
     * @description 数据提交时间开始
     *
     * @var int
     */
    public $instanceCreateFromTimeGMT;

    /**
     * @description 数据提交时间结束
     *
     * @var int
     */
    public $instanceCreateToTimeGMT;

    /**
     * @description 表单中组件数据模糊搜
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
        'appTypes'                  => 'appTypes',
        'corpId'                    => 'corpId',
        'createFromTimeGMT'         => 'createFromTimeGMT',
        'createToTimeGMT'           => 'createToTimeGMT',
        'instanceCreateFromTimeGMT' => 'instanceCreateFromTimeGMT',
        'instanceCreateToTimeGMT'   => 'instanceCreateToTimeGMT',
        'keyword'                   => 'keyword',
        'language'                  => 'language',
        'pageNumber'                => 'pageNumber',
        'pageSize'                  => 'pageSize',
        'processCodes'              => 'processCodes',
        'token'                     => 'token',
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
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->createFromTimeGMT) {
            $res['createFromTimeGMT'] = $this->createFromTimeGMT;
        }
        if (null !== $this->createToTimeGMT) {
            $res['createToTimeGMT'] = $this->createToTimeGMT;
        }
        if (null !== $this->instanceCreateFromTimeGMT) {
            $res['instanceCreateFromTimeGMT'] = $this->instanceCreateFromTimeGMT;
        }
        if (null !== $this->instanceCreateToTimeGMT) {
            $res['instanceCreateToTimeGMT'] = $this->instanceCreateToTimeGMT;
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
     * @return GetNotifyMeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appTypes'])) {
            $model->appTypes = $map['appTypes'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['createFromTimeGMT'])) {
            $model->createFromTimeGMT = $map['createFromTimeGMT'];
        }
        if (isset($map['createToTimeGMT'])) {
            $model->createToTimeGMT = $map['createToTimeGMT'];
        }
        if (isset($map['instanceCreateFromTimeGMT'])) {
            $model->instanceCreateFromTimeGMT = $map['instanceCreateFromTimeGMT'];
        }
        if (isset($map['instanceCreateToTimeGMT'])) {
            $model->instanceCreateToTimeGMT = $map['instanceCreateToTimeGMT'];
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
