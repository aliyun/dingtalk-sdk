<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListApplicationRequest extends Model
{
    /**
     * @description 应用过滤条件, 不填则获取发布到了宜搭应用中心的宜搭应用, 填createdByMe获取我创建的宜搭应用, 填managedByMe获取我管理的宜搭应用
     *
     * @var string
     */
    public $appFilter;

    /**
     * @description 应用名称检索关键词
     *
     * @var string
     */
    public $appNameSearchKeyword;

    /**
     * @description 钉钉组织id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 第几页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description corpId+userId+CorpToken做md5加密计算生成的字符串(每个企业有自己的唯一corpToken), 获取具体计算详情请联系宜搭 dingtalk://dingtalkclient/action/sendmsg?dingtalk_id=somjffs
     *
     * @var string
     */
    public $token;

    /**
     * @description 钉钉userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appFilter'            => 'appFilter',
        'appNameSearchKeyword' => 'appNameSearchKeyword',
        'corpId'               => 'corpId',
        'pageNumber'           => 'pageNumber',
        'pageSize'             => 'pageSize',
        'token'                => 'token',
        'userId'               => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appFilter) {
            $res['appFilter'] = $this->appFilter;
        }
        if (null !== $this->appNameSearchKeyword) {
            $res['appNameSearchKeyword'] = $this->appNameSearchKeyword;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListApplicationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appFilter'])) {
            $model->appFilter = $map['appFilter'];
        }
        if (isset($map['appNameSearchKeyword'])) {
            $model->appNameSearchKeyword = $map['appNameSearchKeyword'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
