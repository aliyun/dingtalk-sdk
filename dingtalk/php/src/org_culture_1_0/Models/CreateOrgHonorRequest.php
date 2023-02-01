<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateOrgHonorRequest extends Model
{
    /**
     * @description 头像挂件   图片尺寸 240*240，不超过1M，支持PNG。图片请使用钉钉媒体资源标识符media_id，参考文档：https://open.dingtalk.com/document/isvapp-server/upload-media-files
     *
     * @var string
     */
    public $avatarFrameMediaId;

    /**
     * @description 背景颜色，如下可选：#FFFBB4 #FFE7BC #FFDAF4 #DAF6A8 #E4D7FF #BFDFFF #B9F2D6
     *
     * @var string
     */
    public $defaultBgColor;

    /**
     * @description 描述 长度30字符 不支持表情图标等
     *
     * @var string
     */
    public $medalDesc;

    /**
     * @description 荣誉图片  图片尺寸 900*900，不超过1M，支持PNG 。图片请使用钉钉媒体资源标识符media_id，参考文档：https://open.dingtalk.com/document/isvapp-server/upload-media-files
     *
     * @var string
     */
    public $medalMediaId;

    /**
     * @description 组织的勋章名称 长度10字符 不支持表情图标等
     *
     * @var string
     */
    public $medalName;

    /**
     * @description 创建荣誉勋章模板人在组织内的userid，需要主/子管理员角色
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'avatarFrameMediaId' => 'avatarFrameMediaId',
        'defaultBgColor'     => 'defaultBgColor',
        'medalDesc'          => 'medalDesc',
        'medalMediaId'       => 'medalMediaId',
        'medalName'          => 'medalName',
        'userId'             => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->avatarFrameMediaId) {
            $res['avatarFrameMediaId'] = $this->avatarFrameMediaId;
        }
        if (null !== $this->defaultBgColor) {
            $res['defaultBgColor'] = $this->defaultBgColor;
        }
        if (null !== $this->medalDesc) {
            $res['medalDesc'] = $this->medalDesc;
        }
        if (null !== $this->medalMediaId) {
            $res['medalMediaId'] = $this->medalMediaId;
        }
        if (null !== $this->medalName) {
            $res['medalName'] = $this->medalName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateOrgHonorRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['avatarFrameMediaId'])) {
            $model->avatarFrameMediaId = $map['avatarFrameMediaId'];
        }
        if (isset($map['defaultBgColor'])) {
            $model->defaultBgColor = $map['defaultBgColor'];
        }
        if (isset($map['medalDesc'])) {
            $model->medalDesc = $map['medalDesc'];
        }
        if (isset($map['medalMediaId'])) {
            $model->medalMediaId = $map['medalMediaId'];
        }
        if (isset($map['medalName'])) {
            $model->medalName = $map['medalName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
